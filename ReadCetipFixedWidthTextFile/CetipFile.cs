using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadCetipFixedWidthTextFile
{
    [FileHelpers.FixedLengthRecord(FileHelpers.FixedMode.AllowMoreChars)]
    internal class CetipFileHeader
    {
        [FileHelpers.FieldFixedLength(5)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        private string idSistema;
        public string IdSistema { get { return idSistema; } }

        [FileHelpers.FieldFixedLength(1)]
        public string idTipoLinha;
        public string IdTipoLinha { get { return idTipoLinha; } }

        [FileHelpers.FieldFixedLength(4)]
        public string codigoOperacao;
        public string CodigoOperacao { get { return codigoOperacao; } }

        [FileHelpers.FieldFixedLength(20)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string participanteGerouArquivo;
        public string ParticipanteGerouArquivo { get { return participanteGerouArquivo; } }

        [FileHelpers.FieldFixedLength(8)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string data;
        public string Data { get { return data; } }
    }

    [FileHelpers.FixedLengthRecord(FileHelpers.FixedMode.AllowMoreChars)]
    internal class CetipFileRecord
    {
        [FileHelpers.FieldFixedLength(5)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        private string idSistema;
        public string IdSistema { get { return idSistema; } }

        [FileHelpers.FieldFixedLength(1)]
        public string idTipoLinha;
        public string IdTipoLinha { get { return idTipoLinha; } }

        [FileHelpers.FieldFixedLength(4)]
        public string codigoOperacao;
        public string CodigoOperacao { get { return codigoOperacao; } }

        [FileHelpers.FieldFixedLength(10)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string meuNumero;
        public string MeuNumero { get { return meuNumero; } }

        [FileHelpers.FieldFixedLength(8)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string parte;
        public string Parte { get { return parte; } }

        [FileHelpers.FieldFixedLength(14)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string cpfCnpjClienteParte;
        public string CpfCnpjClienteParte { get { return cpfCnpjClienteParte; } }

        [FileHelpers.FieldFixedLength(2)]
        public string cestaGarantiasParte;
        public string CestaGarantiasParte { get { return cestaGarantiasParte; } }

        [FileHelpers.FieldFixedLength(10)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string comissaoParte;
        public string ComissaoParte { get { return comissaoParte; } }

        [FileHelpers.FieldFixedLength(8)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string contraParte;
        public string ContraParte { get { return contraParte; } }

        [FileHelpers.FieldFixedLength(14)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string cpfCnpjClienteContraParte;
        public string CpfCnpjClienteContraParte { get { return cpfCnpjClienteContraParte; } }

        [FileHelpers.FieldFixedLength(2)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string cestaGarantiasContraParte;
        public string CestaGarantiasContraParte { get { return cestaGarantiasContraParte; } }

        [FileHelpers.FieldFixedLength(10)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string comissaoContraparte;
        public string ComissaoContraparte { get { return comissaoContraparte; } }

        [FileHelpers.FieldFixedLength(8)]
        public string dataInicio;
        public string DataInicio { get { return dataInicio; } }

        [FileHelpers.FieldFixedLength(8)]
        public string dataVencimento;
        public string DataVencimento { get { return dataVencimento; } }

        [FileHelpers.FieldFixedLength(2)]
        public string tipoAdesao;
        public string TipoAdesao { get { return tipoAdesao; } }

        [FileHelpers.FieldFixedLength(12)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string valorBase;
        public string ValorBase { get { return valorBase; } }

        [FileHelpers.FieldFixedLength(2)]
        public string funcionalidades;
        public string Funcionalidades { get { return funcionalidades; } }

        [FileHelpers.FieldFixedLength(2)]
        public string agendaPremio;
        public string AgendaPremio { get { return agendaPremio; } }

        [FileHelpers.FieldFixedLength(2)]
        public string reset;
        public string Reset { get { return reset; } }

        [FileHelpers.FieldFixedLength(100)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string observacao;
        public string Observacao { get { return observacao; } }

        [FileHelpers.FieldFixedLength(8)]
        public string dataOperacaoTermo;
        public string DataOperacaoTermo { get { return dataOperacaoTermo; } }

        [FileHelpers.FieldFixedLength(2)]
        public string indiceTermo;
        public string IndiceTermo { get { return indiceTermo; } }

        [FileHelpers.FieldFixedLength(5)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string percentualTermo;
        public string PercentualTermo { get { return percentualTermo; } }

        [FileHelpers.FieldFixedLength(18)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string puOriginal;
        public string PuOriginal { get { return puOriginal; } }

        [FileHelpers.FieldFixedLength(5)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string tipoClasse;
        public string TipoClasse { get { return tipoClasse; } }

        [FileHelpers.FieldFixedLength(320)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string descricao;
        public string Descricao { get { return descricao; } }

        [FileHelpers.FieldFixedLength(42)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string branco;
        public string Branco { get { return branco; } }

        [FileHelpers.FieldFixedLength(5)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string percentualParte;
        public string PercentualParte { get { return percentualParte; } }

        [FileHelpers.FieldFixedLength(2)]
        public string curvaParte;
        public string CurvaParte { get { return curvaParte; } }

        [FileHelpers.FieldFixedLength(8)]
        public string trEscolhidaParte;
        public string TREscolhidaParte { get { return trEscolhidaParte; } }

        [FileHelpers.FieldFixedLength(2)]
        public string sinalTaxaParte;
        public string SinalTaxaParte { get { return sinalTaxaParte; } }

        [FileHelpers.FieldFixedLength(7)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string jurosParte;
        public string JurosParte { get { return jurosParte; } }

        [FileHelpers.FieldFixedLength(16)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string limiteInferior;
        public string LimiteInferior { get { return limiteInferior; } }

        [FileHelpers.FieldFixedLength(16)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string limiteSuperior;
        public string LimiteSuperior { get { return limiteSuperior; } }

        [FileHelpers.FieldFixedLength(5)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string percentualContraparte;
        public string PercentualContraparte { get { return percentualContraparte; } }

        [FileHelpers.FieldFixedLength(2)]
        public string curvaContraparte;
        public string CurvaContraparte { get { return curvaContraparte; } }

        [FileHelpers.FieldFixedLength(8)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string trEscolhidaContraparte;
        public string TREscolhidaContraparte { get { return trEscolhidaContraparte; } }

        [FileHelpers.FieldFixedLength(2)]
        public string sinalTaxaContraparte;
        public string SinalTaxaContraparte { get { return sinalTaxaContraparte; } }

        [FileHelpers.FieldFixedLength(7)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string jurosContraparte;
        public string JurosContraparte { get { return jurosContraparte; } }

        [FileHelpers.FieldFixedLength(16)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string limiteInferiorContraparte;
        public string LimiteInferiorContraparte { get { return limiteInferiorContraparte; } }

        [FileHelpers.FieldFixedLength(16)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string limiteSuperiorContraparte;
        public string LimiteSuperiorContraparte { get { return limiteSuperiorContraparte; } }

        [FileHelpers.FieldFixedLength(2)]
        public string parteContraparte;
        public string ParteContraparte { get { return parteContraparte; } }

        [FileHelpers.FieldFixedLength(15)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string cupomLimpo;
        public string CupomLimpo { get { return cupomLimpo; } }

        [FileHelpers.FieldFixedLength(5)]
        [FileHelpers.FieldTrim(FileHelpers.TrimMode.Right)]
        public string percentualTerceiraCurva;
        public string PercentualTerceiraCurva { get { return percentualTerceiraCurva; } }
    }
}
