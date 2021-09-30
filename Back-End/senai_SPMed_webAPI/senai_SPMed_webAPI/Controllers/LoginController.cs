﻿using Microsoft.AspNetCore.Mvc;
using senai_SPMed_webAPI.Domains;
using senai_SPMed_webAPI.Interfaces;
using senai_SPMed_webAPI.Repositories;
using System;
using senai_SPMed_webAPI.LoginViewModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace senai_SPMed_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.Login(login.Email, login.Senha);

                if (usuarioBuscado == null)
                {
                    return BadRequest("E-mail ou Senha inválidos!");
                }

                var claims = new[]
                {
                    // Formato da Claim = TipoDaClaim, ValorDaClaim
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioBuscado.IdTipoUsuario.ToString())
                };

                // Caso encontre, prossegue para a criação do token

                // Define os dados que serão fornecidos no token - Payload

                // Define a chave de acesso ao token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("spmed-chave-autenticacao"));

                // Define as credenciais do token - Header
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                // Gerar o token
                var token = new JwtSecurityToken(
                    issuer: "SpMed.webAPI",                // emissor do token
                    audience: "SpMed.webAPI",              // destinatário do token
                    claims: claims,                         // dados definidos acima (linha 59)
                    expires: DateTime.Now.AddMinutes(30),   // tempo de expiração
                    signingCredentials: creds               // credenciais do token
                );

                // Retorna um status code 200 - Ok com o token criado
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (System.Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
