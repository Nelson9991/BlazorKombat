using System.Collections.Generic;
using System.Net.Http;

namespace BlazorKombat.Models
{
    public class Fighter
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public MultipartFormDataContent? Sprite { get; set; }
        public List<Ability>? Abilities { get; set; }
    }
}
