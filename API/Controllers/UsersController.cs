﻿using API.Contracts;
using API.Data;
using API.DTOs;
using API.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            //var users = await _userRepository.GetUsersAsync();
            //var usersToRetun = _mapper.Map<IEnumerable<MemberDto>>(users);
            //return Ok(usersToRetun);

            var users = await _userRepository.GetMembersAsync();
            return Ok(users);
        }

        [HttpGet("{userName}")]
        public async Task<ActionResult<MemberDto>> GetUser(string userName)
        {
            //var user = await _userRepository.GetUserByUserNameAsync(userName);
            //return _mapper.Map<MemberDto>(user);

            var user = await _userRepository.GetMemberAsync(userName);
            return user;
        }
    }
}
