CREATE TABLE `Produto` (
  `idProduto` integer PRIMARY KEY,
  `idCategoria` integer,
  `nome` varchar(255),
  `preco` double,
  `quantidade` integer,
  `marca` varchar(255)
);

CREATE TABLE `Categoria` (
  `idCategoria` integer PRIMARY KEY,
  `categoria` varchar(255)
);

ALTER TABLE `Produto` ADD FOREIGN KEY (`idCategoria`) REFERENCES `Categoria` (`idCategoria`);
