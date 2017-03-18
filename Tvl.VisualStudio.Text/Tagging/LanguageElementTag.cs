namespace Tvl.VisualStudio.Text.Tagging
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Windows.Media;
    using Microsoft.VisualStudio.Text;

    public class LanguageElementTag : ILanguageElementTag
    {
        public LanguageElementTag(string name, string category, ImageSource glyph, SnapshotSpan target)
        {
            ContractSlim.Requires<ArgumentNullException>(name != null, "name");
            ContractSlim.Requires<ArgumentNullException>(category != null, "category");
            ContractSlim.Requires<ArgumentException>(!string.IsNullOrEmpty(name));
            ContractSlim.Requires<ArgumentException>(!string.IsNullOrEmpty(category));

            this.Name = name;
            this.Category = category;
            this.Glyph = glyph;
            this.Target = target;
        }

        public string Name
        {
            get;
            private set;
        }

        public string Category
        {
            get;
            private set;
        }

        public ImageSource Glyph
        {
            get;
            private set;
        }

        public SnapshotSpan Target
        {
            get;
            private set;
        }
    }
}
