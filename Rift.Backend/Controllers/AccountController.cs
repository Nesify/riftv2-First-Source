// Decompiled with JetBrains decompiler
// Type: Rift.Backend.Controllers.AccountController
// Assembly: Rift.Backend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4E0524C8-F3A7-4280-BB75-5F2B0F25621A
// Assembly location: C:\Users\vloge\Downloads\Rift-2.0\Rift.Backend.dll

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rift.Backend.Models.Account;
using Rift.Backend.Models.Exceptions.OAuth;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rift.Backend.Controllers
{
  [Route("[controller]/api")]
  [ApiController]
  public class AccountController : ControllerBase
  {
    [HttpPost("oauth/token")]
    public ActionResult<OAuthToken> CreateOAuthToken([FromForm] string grant_type)
    {
      try
      {
        Program.ClientId = Encoding.UTF8.GetString(Convert.FromBase64String(this.Request.Headers["authorization"].ToString().Split(" ")[1])).Split(":")[0];
        if (Program.ClientId != "ec684b8c687f479fadea3cb2ad83f5c6")
          throw new InvalidClientException();
      }
      catch
      {
        throw new InvalidClientException();
      }
      IFormCollection form = this.Request.Form;
      if (grant_type == "client_credentials")
        return (ActionResult<OAuthToken>) new OAuthToken(Program.ClientId);
      if (!(grant_type == "password"))
        throw new UnsupportedGrantTypeException(grant_type);
      if (string.IsNullOrWhiteSpace((string) form["username"]))
        throw new InvalidRequestException("username");
      Program.Id = Tools.CreateRandomHexString();
      Program.DisplayName = form["username"].ToString().Split("@")[0];
      return (ActionResult<OAuthToken>) new OAuthToken(Program.ClientId, Program.Id, Program.DisplayName);
    }

    [HttpGet("oauth/verify")]
    public ActionResult<OAuthToken> VerifyOAuthToken() => (ActionResult<OAuthToken>) new OAuthToken(Program.ClientId, Program.Id, Program.DisplayName);

    [HttpDelete("oauth/sessions/kill")]
    [HttpDelete("oauth/sessions/kill/{accessToken}")]
    public ActionResult KillOAuthSession(string accessToken) => (ActionResult) this.NoContent();

    [HttpGet("public/account")]
    public ActionResult<List<Rift.Backend.Models.Account.Account>> GetAccountLookupByIds() => (ActionResult<List<Rift.Backend.Models.Account.Account>>) new List<Rift.Backend.Models.Account.Account>()
    {
      new Rift.Backend.Models.Account.Account()
      {
        Id = Program.Id,
        DisplayName = Program.DisplayName
      }
    };

    [HttpGet("public/account/{accountId}")]
    public ActionResult<Rift.Backend.Models.Account.Account> GetAccountLookupById(
      string accountId)
    {
      return (ActionResult<Rift.Backend.Models.Account.Account>) new Rift.Backend.Models.Account.Account()
      {
        Id = Program.Id,
        DisplayName = Program.DisplayName
      };
    }

    [HttpGet("public/account/{accountId}/externalAuths")]
    public ActionResult<object> GetExternalAuthsById(string accountId) => (ActionResult<object>) new object();
  }
}
