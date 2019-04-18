# Music Maker

  ## A genetic algorithm to generate a chord progression using only white notes for root notes
  
  O algoritmo dispõe-se em duas classes: Dna e Crossover. 
  Na classe Dna há dois vetores com as notas músicas. Um contendo todas as notas e outro contendo somente as notas brancas, as quais serão utilizadas como as notas raiz para os acordes.
  Para gerar a população, o método construtor que gera os cromossomos aleatoriamente é aplicado. Após, é feito o cálculo de pontuação do indivíduo seguindo as regras de padrão humano.
  Neste momento, temos a definição do tamanho da população -  a geração da população e a pontuação dos indivíduos.
  A classe Crossover detém as tarefas de classificar a população baseando-se na pontuação de cada indivíduo e fazer o cruzamento de informações dos indivíduos utilizando o método Roleta.
