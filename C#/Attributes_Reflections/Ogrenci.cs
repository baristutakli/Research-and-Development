namespace Attributes_Reflections
{
    using System;

    /// <summary>
    /// Defines the <see cref="Ogrenci" />.
    /// </summary>
    public class Ogrenci
    {
        /// <summary>
        /// Defines the _tc.
        /// </summary>
        private string _tc = "123456";

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Tc.
        /// </summary>
        public string Tc
        {
            get { return _tc; }
            set { _tc = value; }
        }

        /// <summary>
        /// Defines the myInt.
        /// </summary>
        private int myInt = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ogrenci"/> class.
        /// </summary>
        /// <param name="newINt">The newINt<see cref="int"/>.</param>
        public Ogrenci(int newINt)
        {
            myInt = newINt;
        }

        /// <summary>
        /// The Change_tc.
        /// </summary>
        /// <param name="tc">The tc<see cref="string"/>.</param>
        private void Change_tc(string tc)
        {

            _tc = tc;
            Console.WriteLine("changed" + _tc);
        }

        /// <summary>
        /// The ChangeTc.
        /// </summary>
        /// <param name="tc">The tc<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string ChangeTc(string tc)
        {
            Tc = tc;
            return Tc;
        }

        /// <summary>
        /// The Show.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int Show()
        {

            return myInt;
        }
    }
}
