using DesafioDIO_AOP;

Repository<ContaPoupanca> contaPoupanca = new Repository<ContaPoupanca>();
Repository<ContaInvestimento> contaInvestimento = new Repository<ContaInvestimento>();

contaPoupanca.calcularValorTarifaManutencao();
contaInvestimento.calcularValorTarifaManutencao();
