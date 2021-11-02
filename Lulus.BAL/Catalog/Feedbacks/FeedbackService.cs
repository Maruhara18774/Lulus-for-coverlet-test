using Lulus.BAL.Catalog.Feedbacks.Interfaces;
using Lulus.Data.EF;
using Lulus.Data.Entities;
using Lulus.ViewModels.Feedbacks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.BAL.Catalog.Feedbacks
{
    public class FeedbackService : IFeedbackService
    {
        private readonly LulusDBContext _context;

        public FeedbackService(LulusDBContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateFeedback(CreateFeedbackRequest request)
        {
            if (request.Star > 5
                || request.Star < 1
                || String.IsNullOrEmpty(request.Title)) return false;
            var checkUser = await _context.Users.Where(x => x.Id == new Guid(request.UserID)).FirstOrDefaultAsync();
            if (checkUser == null) return false;
            var checkProduct = await _context.Products.Where(x => x.Product_ID == request.ProductID).FirstOrDefaultAsync();
            if (checkProduct == null) return false;
            var feedback = new Feedback()
            {
                Feedback_Rating = request.Star,
                Feedback_Title = request.Title,
                Feedback_Content = request.Content,
                User_ID = new Guid(request.UserID),
                Product_ID = request.ProductID,
                CreatedDate = DateTime.Now
            };
            _context.Feedbacks.Add(feedback);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
