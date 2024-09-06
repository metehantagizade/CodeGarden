using MediatR;

namespace Restaurants.Application.Dishes.Commands.DeleteDishes;

public class DeleteDishesForRestaurantCommand(Guid restaurantId) : IRequest
{
    public Guid RestaurantId { get; } = restaurantId;
}
