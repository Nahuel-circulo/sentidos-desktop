using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentidos.Coneccion.NeuvasLlamadas
{

    public partial class LlamadaComidasDos
    {
        public List<Doc> Docs { get; set; }
        public long TotalDocs { get; set; }
        public long Limit { get; set; }
        public long TotalPages { get; set; }
        public long Page { get; set; }
        public long PagingCounter { get; set; }
        public bool HasPrevPage { get; set; }
        public bool HasNextPage { get; set; }
        public object PrevPage { get; set; }
        public object NextPage { get; set; }
    }

    public partial class Doc
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public Image Image { get; set; }
        public bool Delivery { get; set; }
        public Categoria Categoria { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class Categoria
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class Image
    {
        public string Id { get; set; }
        public string Filename { get; set; }
        public string MimeType { get; set; }
        public long Filesize { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public Sizes Sizes { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public Uri Url { get; set; }
    }

    public partial class Sizes
    {
        public Card Thumbnail { get; set; }
        public Card Card { get; set; }
        public Tablet Tablet { get; set; }
    }

    public partial class Card
    {
        public long Width { get; set; }
        public long Height { get; set; }
        public string MimeType { get; set; }
        public long Filesize { get; set; }
        public string Filename { get; set; }
        public Uri Url { get; set; }
    }

    public partial class Tablet
    {
    }
}

