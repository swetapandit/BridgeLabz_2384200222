﻿using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Services;

namespace Second.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloAppController : ControllerBase
{
    RegisterHelloBL _registerHelloBL;

    public HelloAppController(RegisterHelloBL registerHelloBL)
    {
        _registerHelloBL = registerHelloBL;
    }

    [HttpGet]
    public string Get()
    {
        return _registerHelloBL.registration("Value from controller");
    }

    [HttpGet("login")]
    public string Login()
    {
        return "Welcome to Registration Page";
    }
}

