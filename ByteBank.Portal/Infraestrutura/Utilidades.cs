﻿namespace ByteBank.Portal.Infraestrutura
{
    public static class Utilidades
    {
        public static bool ehArquivo(string path)
        {
            var partesPath = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var ultimaParte = partesPath.Last();

            return ultimaParte.Contains('.');
        }

        public static string ConvertParthParaNomeAssembly(string path)
        {
            // /Assets/css/styles.css
            // /Assets/js/main.js

            var prefixoAssembly = "ByteBank.Portal";
            var pathComPontos = path.Replace("/", ".");

            var nomeCompleto = $"{prefixoAssembly}{pathComPontos }";

            return nomeCompleto;
        }

        public static string ObterTipoDeConteudo(string path)
        {
            if (path.EndsWith(".css"))
                return "text/css; charset=utf-8";

            if (path.EndsWith(".js"))
                return "application/js; charset=utf-8";
            
            if (path.EndsWith(".html"))
                return "text/html; charset=utf-8";

            throw new NotImplementedException("Tipo de conteúdo não previsto.");
        }
    }
}
