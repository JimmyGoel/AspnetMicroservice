﻿using Discount.Grpc.Entites;
using System.Threading.Tasks;

namespace Discount.Grpc.Repositories
{
    public interface IDiscountRepository
    {
        Task<bool> CreateDiscount(Coupon coupon);
        Task<bool> DeleteDiscount(string productName);
        Task<Coupon> GetDiscount(string productName);
        Task<bool> UpdateDiscount(Coupon coupon);
    }
}