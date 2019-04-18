# Music Maker

## Um Algoritmo Genético para gerar uma progressão de acordes usando apenas as notas brancas como notas raiz
  
O algoritmo dispõe-se em duas classes _no momento_: __Dna__ e __Crossover__.

Na classe *Dna* há dois vetores com as notas músicas. Um contendo todas as notas e outro contendo somente as notas brancas, as quais serão utilizadas como as notas raiz para os acordes.

Para gerar a população, o método construtor que gera os cromossomos (indivíduos) aleatoriamente é aplicado. Após, é feito o cálculo de pontuação do indivíduo seguindo as regras de __padrão humano__.

Neste momento, temos a definição do tamanho da população, a geração da população e a pontuação dos indivíduos (__Dna *objects*__).

A classe __Crossover__ detém as tarefas de classificar a população baseando-se na pontuação de cada indivíduo e fazer o cruzamento de informações dos indivíduos selecionando-os aleatoriamente (*Até o momento*).
