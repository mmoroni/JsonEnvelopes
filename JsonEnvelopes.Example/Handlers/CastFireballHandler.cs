﻿using JsonEnvelopes.Example.Commands;
using JsonEnvelopes.Example.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JsonEnvelopes.Example.Handlers
{
    public class CastFireballHandler : ICommandHandler<CastFireball>, IRequestHandler<CastFireball, bool>
    {
        public Task<bool> HandleAsync(CastFireball command)
        {
            Console.WriteLine($"{command}");

            return Task.FromResult(true);
        }

        public Task<bool> HandleAsync(object command) =>
            HandleAsync((CastFireball)command);

        public Task<bool> Handle(CastFireball command, CancellationToken cancellationToken) =>
            HandleAsync(command);
    }
}
