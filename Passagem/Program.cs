using Passagem;

Cliente cliente1 = new ("Victor",10,"12345678909");
Cliente cliente2 = new ("Valdiclei",10, "12345678909");

PassagemOnibus passagem1 = new (12.50, "Paraíba", DateTime.Now, DateTime.Now, "Crédito", "13B", cliente1);
PassagemOnibus passagem2 = new (15.50, "Mato Grosso", DateTime.Now, DateTime.Now, "Débito", "13C", cliente2);

Servico servico = new ();

servico.Inserir(passagem1);
servico.Inserir(passagem2);

servico.Apresentar("12345678909");

servico.Deletar("Victor");

servico.Apresentar("Victor");

servico.Alterar("12345678909", "Bruno", 20, "198765433212", 32.50, "São Paulo", DateTime.Now, DateTime.Now, "Débito", "13C");

servico.Apresentar("198765433212");
