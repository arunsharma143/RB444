﻿using RB444.Models.Model;
using System.Threading.Tasks;

namespace RB444.Core.IServices
{
    public interface IAccountService
    {
        /// <summary>
        /// Update Assign Coin
        /// </summary>
        /// <param name="AssignCoin"></param>
        /// <param name="LoginUserId"></param>
        /// <returns></returns>
        Task<CommonReturnResponse> UpdateAssignCoinAsync(long AssignCoin, int LoginUserId);
    }
}