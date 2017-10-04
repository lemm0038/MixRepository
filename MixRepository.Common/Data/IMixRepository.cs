using System;
using System.Collections.Generic;
using MixRepository.Common.Model;

namespace MixRepository.Common.Data
{
    public interface IMixRepository
    {
        void Add(IEnumerable<Mix> mixes);
        void Update(Mix mix);
        void Delete(int mixId);
        void GetById(int mixId);
    }
}
