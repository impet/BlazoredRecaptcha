namespace BlazoredRecaptcha.Models
{
    /// <summary>
    /// The reCAPTCHA configuration model, this contains the keys required to get reCAPTCHA working correctly
    /// </summary>
    public class RecaptchaConfiguration
    {
        /// <summary>
        /// The site key from Google, this is public and everyone can see this
        /// </summary>
        public string SiteKey { get; set; }
        /// <summary>
        /// Your secret key from Google, this is private and is used for token validation
        /// </summary>
        public string SecretKey { get; set; }
    }
}