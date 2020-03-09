using System;

namespace ProductMaint
{
    public class Software : Product
	{
		private string version;

        public Software()
		{
		}

        public Software(string code, string description, string version,
            decimal price) : base(code, description, price)
        {
            this.Version = version;
        }

        public string Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }
        }

        public override string GetDisplayText(string sep)
        {
            return base.GetDisplayText(sep) + ", Version " + Version;
        }

	}
}
