using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PrimeiraEntregaRevisao.Model;

namespace PrimeiraEntregaRevisao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MegaSenaController : ControllerBase
    {

        private readonly string _jogoCaminhoArquivo;

        public MegaSenaController()
        {
            _jogoCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonNumero", "Numeros.json");
        }

        #region Métodos arquivo
        private List<RegistroJogo> LerJogosDoArquivo()
        {
            if (!System.IO.File.Exists(_jogoCaminhoArquivo))
            {
                return new List<RegistroJogo>();
            }

            string json = System.IO.File.ReadAllText(_jogoCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<RegistroJogo>>(json);
        }       

        private void EscreverJogoNoArquivo(List<RegistroJogo> produtos)
        {
            string json = JsonConvert.SerializeObject(produtos);
            System.IO.File.WriteAllText(_jogoCaminhoArquivo, json);
        }
        #endregion



        [HttpPost]
        public IActionResult Post(RegistroJogo registroJogo)
        {
            if(registroJogo.PrimeiroNum != registroJogo.SegundoNum
              && registroJogo.SegundoNum != registroJogo.TerceiroNum
              && registroJogo.TerceiroNum != registroJogo.QuartoNum
              && registroJogo.QuartoNum != registroJogo.QuintoNum
              && registroJogo.QuintoNum != registroJogo.SextoNum

              )
            {
                var listaJogos = LerJogosDoArquivo();
                listaJogos.Add(registroJogo);
                EscreverJogoNoArquivo(listaJogos);
                return Ok("Jogo Registrado com sucesso!");

            }
            else
            {
                return BadRequest("Existem numeros repetidos, o jogo não pode ser gravado!");

            }

        }

            [HttpGet] public IActionResult Get()
            {
                return Ok(LerJogosDoArquivo());
            }
    }
}
