using Multishop.Order.Application.Interfaces;
using Multishop.Order.Domain.Entites;
using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class CreateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
        public CreateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateAddressCommand createAddressCommand)
        {
            await _repository.CreateAsync(new Address
            {
                City = createAddressCommand.City,
                District = createAddressCommand.District,
                UserId = createAddressCommand.UserId,
                Detail = createAddressCommand.Detail
            });
        }
    }
}
