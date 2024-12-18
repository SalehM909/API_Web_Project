using API_Web_Project.DTO;
using API_Web_Project.Model;

namespace API_Web_Project.Services
{
    public interface IReviewService
    {
        Review AddReview(ReviewDto model, int userId);
        Review UpdateReview(int reviewId, ReviewDto model, int userId);
    }
}