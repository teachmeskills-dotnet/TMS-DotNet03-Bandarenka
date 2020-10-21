namespace Filmary.BLL.Models
{     /// <summary>
      /// Transport model from groupeprofile
      /// </summary>
    public class Profiledto
    {

        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public string UserId { get; set; }


        /// <summary>
        /// FullName
        /// </summary>
        public string FullName { get; set; }

    }
}