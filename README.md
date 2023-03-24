# GeradorDeDocumentos
O projeto de automatização de um documento Word surgiu durante um trabalho freelance que realizei para a Escola Adventista do Chile. O objetivo do programa é automatizar o processo de preenchimento de uma ficha de diagnósticos de um psicólogo escolar, facilitando e agilizando esse processo.

O programa tem como principal método a função "GerarFicha", que aceita uma série de argumentos para preencher diferentes seções do documento, como informações do estudante, do responsável legal, do curso, motivos, atividades, entre outras. Cada seção do documento é mapeada para uma tabela específica no documento do Word, e as informações são inseridas nas células correspondentes.

O método "SalvarArquivoWord" é responsável por salvar o documento gerado como um arquivo Word, permitindo que o usuário selecione um diretório para salvar o arquivo e definindo o nome do arquivo como o nome do estudante fornecido.

Já o método "SalvarEmPDF" converte o documento do Word gerado em um arquivo PDF e o salva em um diretório selecionado pelo usuário.

Por fim, o método "SelecionarArquivos" permite que o usuário selecione um arquivo Word para ser processado.

Essa solução é uma ótima maneira de simplificar e automatizar processos repetitivos e trabalhosos, permitindo que profissionais como psicólogos escolares possam se concentrar em tarefas mais importantes e estratégicas.
