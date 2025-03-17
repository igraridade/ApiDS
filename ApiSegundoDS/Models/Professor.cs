namespace ApiSegundoDS.Models
{
    public class Professor
    {
        public int Id { get; set; }

        public string? Nome { get; set; }
        public string? RMA { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public Escola escola { get; set; }
        public Professor Professor { get; set; }
    }
}

    }
}