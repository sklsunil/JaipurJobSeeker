using System;
using System.Collections.Generic;

namespace Web.Api.Core.Dto.GatewayResponses.Repositories
{
  public sealed class CreateUserResponse : BaseGatewayResponse
  {
    public Guid Id { get; }
    public CreateUserResponse(Guid id, bool success = false, IEnumerable<Error> errors = null) : base(success, errors)
    {
      Id = id;
    }
  }
}
