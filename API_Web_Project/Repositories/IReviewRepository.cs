using API_Web_Project.Model;

namespace API_Web_Project.Repositories
{
    public interface IReviewRepository
    {
        void AddReview(Review review);
        Review GetById(int reviewId);
        Review GetReviewByUserAndProduct(int userId, int productId);
        IEnumerable<Review> GetReviewsByProductId(int productId);
        void UpdateReview(Review review);
    }
}