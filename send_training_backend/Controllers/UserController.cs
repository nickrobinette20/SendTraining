using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using send_training_backend.DTOs;
using send_training_backend.Models;
using send_training_backend.Services;
using System.Data;

namespace send_training_backend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            this._userService = userService;
        }

        [HttpGet("all")]
        public IResult GetAllUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();
                if (users == null)
                {
                    return Results.NotFound();
                }
                var dtos = users.Select(user => new UserDTO(user)).ToArray();

                return Results.Ok(dtos);
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        [HttpGet("id")]
        public IResult GetUserById(int id)
        {
            try
            {
                var user = _userService.GetUserById(id);
                if (user == null)
                {
                    return Results.NotFound();
                }
                var dto = new UserDTO(user);
                return Results.Ok(dto);
            }
            catch (Exception)
            {

                throw;
            }


        }

        [HttpGet("email")]
        public IResult GetUserByEmail(String email)
        {
            try
            {
                var user = _userService.GetUserByEmail(email);
                if (user == null)
                {
                    return Results.NotFound();
                }
                var dto = new UserDTO(user);
                return Results.Ok(dto);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet("username")]
        public IResult GetUserByUsername(String username)
        {
            try
            {
                var user = _userService.GetUserByUsername(username);
                if (user == null) 
                {
                    return Results.NotFound();
                }
                var dto = new UserDTO(user);
                return Results.Ok(dto);

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("points")]
        public IResult GetAllPoints()
        {
            try
            {
                var users = _userService.GetAllPoints();
                if (users == null)
                {
                    return Results.NotFound();
                }
                var dtos = users.Select(user => new UserDTO(user)).ToArray();
                return Results.Ok(dtos);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        [HttpGet("usernames")]
        public IResult GetAllUsernames()
        {
            try
            {
                var users = _userService.GetAllUsernames();
                if (users == null)
                {
                    return Results.NotFound();
                }
                var dtos = users.Select(user => new UserDTO(user)).ToArray();
                return Results.Ok(dtos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("grades")]
        public IResult GetAllHardestGrade()
        {
            try
            {
                var users = _userService.GetAllHardestGrade();
                if (users == null)
                {
                    return Results.NotFound();
                }
                var dtos = users.Select(user => new UserDTO(user)).ToArray();
                return Results.Ok(dtos);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
