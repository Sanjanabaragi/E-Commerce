using ECommerce.Application.DTOs.Auth;
using ECommerce.Application.Interfaces.Services;
using ECommerce.Shared.Constants;
using ECommerce.Shared.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(
        RegisterRequestDto request)
    {
        var response =
            await _authService.RegisterAsync(request);

        return Ok(
            new ApiResponse<AuthResponseDto>(
                true,
                Messages.UserCreatedSuccessfully,
                response));
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(
        LoginRequestDto request)
    {
        var response =
            await _authService.LoginAsync(request);

        return Ok(
            new ApiResponse<AuthResponseDto>(
                true,
                Messages.LoginSuccessful,
                response));
    }
}