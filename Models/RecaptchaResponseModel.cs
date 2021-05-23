
namespace BlazoredRecaptcha.Models
{
    public struct RecaptchaResponse
    {
        /// <summary>
        /// True if the token is valid, false if it is invalid
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// The bot likelihood score
        /// </summary>
        public float Score { get; set; }
    }
}