using Passagem;

Cliente cliente1 = new ("Victor",10,"12345678909");
Cliente cliente2 = new ("Valdiclei",10,"098765433212");

PassagemOnibus passagem1 = new (12.50, DateTime.Now, DateTime.Now, "Crédito", "13B", cliente1);
PassagemOnibus passagem2 = new (15.50, DateTime.Now, DateTime.Now, "Débito", "13C", cliente2);

Servico servico = new ();

servico.Inserir(passagem1);
servico.Inserir(passagem2);

servico.Apresentar(TipoIdentificacao.Nome);

servico.Deletar(TipoIdentificacao.Nome);

servico.Apresentar(TipoIdentificacao.Nome);

servico.Alterar(TipoIdentificacao.Nome, "Bruno", 20, "198765433212", 32.50, DateTime.Now, DateTime.Now, "Débito", "13C");

servico.Apresentar(TipoIdentificacao.Nome);
