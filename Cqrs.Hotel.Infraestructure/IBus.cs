﻿using System.Threading.Tasks;
using Cqrs.Hotel.Command.Infraestructure;
using Cqrs.Hotel.Domain;

namespace Cqrs.Hotel.Infraestructure
{
    public interface IBus
    {
        Task<TResponse> Send<TCommand, TResponse>(TCommand command)  where TCommand : IDomainCommand<TResponse>;

        void RaiseEvent<T>(T theEvent) where T : DomainEvent; 
    }
}
