﻿using Core;
using Core.Models;
using Core.Services;

namespace Services
{
    public class OficioService : IOficioService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OficioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateOficio(Oficio oficio)
        {
            try
            {
                await _unitOfWork.OficioRepository.CreateAsync(oficio);
                var result = await _unitOfWork.CommitAsync();
                return true;
            }
            catch (Exception exe)
            {
                throw new Exception(exe.Message);
            }

        }

        public async Task<IEnumerable<Oficio>> GetAll()
        {
            try
            {
                return await _unitOfWork.OficioRepository.GetAllAsync();
            }
            catch (Exception exe)
            {
                throw new Exception(exe.Message);
            }
        }
    }
}