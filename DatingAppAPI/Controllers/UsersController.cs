﻿using DatingAppAPI.Data;
using DatingAppAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        // return a list of users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();

        }

        // api/users/{id}
        // example: api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsersAsync( int id)
        {
            return await _context.Users.FindAsync(id);

        }



    }
}
