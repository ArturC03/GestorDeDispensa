-- Tabela Categoria
CREATE TABLE Categoria (
  idCategoria INT PRIMARY KEY,
  categoria VARCHAR(255) NOT NULL
);

-- Tabela Entrada
CREATE TABLE Entrada (
  idEntrada INT PRIMARY KEY,
  data DATETIME NOT NULL,
  total DOUBLE NOT NULL
);

-- Tabela Produto
CREATE TABLE Produto (
  idProduto INT PRIMARY KEY,
  idCategoria INT NOT NULL,
  idEntrada INT NOT NULL,
  nome VARCHAR(255) NOT NULL,
  preco DOUBLE NOT NULL,
  quantidade INT NOT NULL,
  marca VARCHAR(255) NOT NULL,
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  FOREIGN KEY (idCategoria) REFERENCES Categoria(idCategoria),
  FOREIGN KEY (idEntrada) REFERENCES Entrada(idEntrada)
);
