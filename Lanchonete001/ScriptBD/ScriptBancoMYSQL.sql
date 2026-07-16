DROP DATABASE IF EXISTS BurguerHouse;
CREATE DATABASE BurguerHouse;
USE BurguerHouse;

CREATE TABLE cargos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL UNIQUE,
    descricao VARCHAR(255)
) ENGINE=InnoDB;

INSERT INTO cargos (nome, descricao) VALUES
('Admin', 'Acesso total ao sistema, incluindo configurações e financeiro'),
('Dono', 'Acesso total ao sistema, incluindo configurações e financeiro'),
('Gerente', 'Gerencia operação, estoque, cardápio e equipe'),
('Cozinha', 'Acesso à fila de preparo (Kanban de pedidos)'),
('Garçom', 'Abre mesas, lança pedidos e fecha contas'),
('Financeiro', 'Acesso a relatórios financeiros e fechamento de caixa');

CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(255) NOT NULL,
    cargo_id INT NOT NULL,
    ativo BOOLEAN NOT NULL DEFAULT TRUE,
    criado_em TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_usuario_cargo
        FOREIGN KEY (cargo_id) REFERENCES cargos(id)
        ON DELETE RESTRICT
) ENGINE=InnoDB;

INSERT INTO usuarios (nome, usuario, senha, cargo_id, ativo) VALUES
('Kaio Andrião Dalfior', 'user', 'user', 1, TRUE),
('Dono', 'dono', 'dono', 2, TRUE),
('Gerente', 'gerente', 'gerente', 3, TRUE),
('Cozinha', 'cozinha', 'cozinha', 4, TRUE),
('Garçom', 'garcom', 'garcom', 5, TRUE),
('Financeiro', 'financeiro', 'financeiro', 6, TRUE);

CREATE TABLE insumos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    categoria VARCHAR(60) NOT NULL,
    quantidade_atual DECIMAL(10,3) NOT NULL DEFAULT 0,
    unidade VARCHAR(10) NOT NULL,
    quantidade_minima DECIMAL(10,3) NOT NULL DEFAULT 0,
    preco_unitario DECIMAL(10,2) NOT NULL DEFAULT 0,
    criado_em TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    UNIQUE KEY uk_insumos_nome (nome)
) ENGINE=InnoDB;

INSERT INTO insumos (nome, categoria, quantidade_atual, unidade, quantidade_minima, preco_unitario) VALUES
('Bacon (fatia)', 'Carnes', 48, 'un', 20, 0.80),
('Pão brioche', 'Pães', 15, 'un', 30, 1.20),
('Hambúrguer 150g', 'Carnes', 60, 'un', 25, 4.50),
('Queijo prato (fatia)', 'Laticínios', 8, 'un', 20, 0.60),
('Alface', 'Vegetais', 2.5, 'kg', 3, 6.00),
('Tomate', 'Vegetais', 4, 'kg', 3, 7.00),
('Molho especial', 'Molhos', 3, 'L', 1, 18.00),
('Refrigerante (ml)', 'Bebidas/Insumos líquidos', 12, 'L', 10, 6.00),
('Suco natural (ml)', 'Bebidas/Insumos líquidos', 8, 'L', 5, 9.00),
('Água mineral', 'Bebidas/Insumos líquidos', 40, 'un', 20, 1.50),
('Copo descartável 300ml', 'Embalagens', 200, 'un', 100, 0.15),
('Copo descartável 500ml', 'Embalagens', 150, 'un', 100, 0.20);

CREATE TABLE itens_cardapio (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    categoria VARCHAR(60),
    descricao VARCHAR(255),
    preco_venda DECIMAL(10,2) NOT NULL DEFAULT 0,
    tipo ENUM('Lanche','Bebida') NOT NULL,
    ativo BOOLEAN NOT NULL DEFAULT TRUE,
    criado_em TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

CREATE TABLE ingredientes_receita (
    id INT AUTO_INCREMENT PRIMARY KEY,
    item_cardapio_id INT NOT NULL,
    insumo_id INT NOT NULL,
    quantidade DECIMAL(10,3) NOT NULL,
    unidade VARCHAR(10) NOT NULL,
    CONSTRAINT fk_ingrediente_item
        FOREIGN KEY (item_cardapio_id) REFERENCES itens_cardapio(id)
        ON DELETE CASCADE,
    CONSTRAINT fk_ingrediente_insumo
        FOREIGN KEY (insumo_id) REFERENCES insumos(id)
        ON DELETE RESTRICT,
    UNIQUE KEY uk_item_insumo (item_cardapio_id, insumo_id)
) ENGINE=InnoDB;

CREATE TABLE mesas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    numero INT NOT NULL UNIQUE,
    status ENUM('Livre','Ocupada','Fechando') NOT NULL DEFAULT 'Livre'
) ENGINE=InnoDB;

CREATE TABLE pedidos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    mesa_id INT NOT NULL,
    desconto DECIMAL(10,2) NOT NULL DEFAULT 0,
    enviado_para_cozinha BOOLEAN NOT NULL DEFAULT FALSE,
    status_preparo ENUM('AguardandoPreparo','EmPreparo','Entregue','Finalizado')
        NOT NULL DEFAULT 'AguardandoPreparo',
    forma_pagamento ENUM('Dinheiro','CartaoDebito','CartaoCredito','Pix') NULL,
    aberto_em TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fechado_em TIMESTAMP NULL,
    CONSTRAINT fk_pedido_mesa
        FOREIGN KEY (mesa_id) REFERENCES mesas(id)
        ON DELETE RESTRICT
) ENGINE=InnoDB;

CREATE TABLE itens_pedido (
    id INT AUTO_INCREMENT PRIMARY KEY,
    pedido_id INT NOT NULL,
    item_cardapio_id INT NOT NULL,
    preco_unitario DECIMAL(10,2) NOT NULL,
    quantidade INT NOT NULL DEFAULT 1,
    CONSTRAINT fk_item_pedido_pedido
        FOREIGN KEY (pedido_id) REFERENCES pedidos(id)
        ON DELETE CASCADE,
    CONSTRAINT fk_item_pedido_item_cardapio
        FOREIGN KEY (item_cardapio_id) REFERENCES itens_cardapio(id)
        ON DELETE RESTRICT
) ENGINE=InnoDB;

USE BurguerHouse;

-- =====================================================================
-- INSUMOS ADICIONAIS (cobrindo Porções, Combos, Milk-shakes e mais sabores)
-- =====================================================================
INSERT INTO insumos (nome, categoria, quantidade_atual, unidade, quantidade_minima, preco_unitario) VALUES
    ('Cheddar (fatia)',                'Laticínios',               40,  'un', 15, 0.90),
    ('Pão de forma (fatia)',           'Pães',                     60,  'un', 20, 0.35),
    ('Presunto (fatia)',               'Frios',                    50,  'un', 20, 0.55),
    ('Pão integral',                   'Pães',                     20,  'un', 10, 1.50),
    ('Peito de frango grelhado (filé)','Carnes',                   30,  'un', 10, 5.50),
    ('Frango desfiado',                'Carnes',                   10,  'kg', 3,  22.00),
    ('Requeijão cremoso',              'Laticínios',               5,   'kg', 2,  24.00),
    ('Maionese verde',                 'Molhos',                   4,   'L',  1,  20.00),
    ('Cebola caramelizada',            'Vegetais',                 3,   'kg', 1,  12.00),
    ('Batata frita congelada',         'Porções',                  25,  'kg', 10, 9.00),
    ('Onion rings congelados',         'Porções',                  15,  'kg', 5,  14.00),
    ('Água mineral com gás',           'Bebidas/Insumos líquidos', 30,  'un', 15, 1.80),
    ('Coca-Cola lata 350ml',           'Bebidas/Insumos líquidos', 60,  'un', 24, 3.20),
    ('Guaraná Antarctica lata 350ml',  'Bebidas/Insumos líquidos', 48,  'un', 24, 3.20),
    ('Suco de maracujá (ml)',          'Bebidas/Insumos líquidos', 6,   'L',  3,  10.00),
    ('Sorvete de creme',               'Sorvetes',                 8,   'kg', 3,  28.00),
    ('Leite integral',                 'Laticínios',               20,  'L',  8,  4.50),
    ('Chantilly',                      'Laticínios',               3,   'L',  1,  22.00);

-- =====================================================================
-- ITENS_CARDAPIO (cardápio completo)
-- =====================================================================
INSERT INTO itens_cardapio (nome, categoria, descricao, preco_venda, tipo, ativo) VALUES
    -- Hambúrgueres
    ('X-Salada',                    'Hambúrgueres', 'Pão brioche, hambúrguer, queijo prato, alface e tomate', 19.90, 'Lanche', 1),
    ('X-Bacon',                     'Hambúrgueres', 'Pão brioche, hambúrguer, queijo prato em dobro e bacon', 22.90, 'Lanche', 1),
    ('X-Tudo',                      'Hambúrgueres', 'Dois hambúrgueres, queijo em dobro, bacon, salada e molho especial', 28.90, 'Lanche', 1),
    ('Cheddar Bacon Burger',        'Hambúrgueres', 'Hambúrguer, cheddar, bacon crocante e cebola caramelizada', 24.90, 'Lanche', 1),
    ('Chicken Burger',              'Hambúrgueres', 'Frango grelhado, alface, tomate e maionese verde', 21.90, 'Lanche', 1),
    -- Sanduíches
    ('Misto Quente',                'Sanduíches',   'Pão de forma, presunto e queijo prato, na chapa', 12.90, 'Lanche', 1),
    ('Sanduíche Natural de Frango', 'Sanduíches',   'Pão integral, frango desfiado, alface, tomate e requeijão', 14.90, 'Lanche', 1),
    -- Porções
    ('Batata Frita',                'Porções',      'Porção de batata frita crocante (300g)', 16.90, 'Lanche', 1),
    ('Onion Rings',                 'Porções',      'Anéis de cebola empanados e crocantes (250g)', 18.90, 'Lanche', 1),
    ('Batata com Cheddar e Bacon',  'Porções',      'Batata frita coberta com cheddar derretido e bacon', 24.90, 'Lanche', 1),
    -- Combos
    ('Combo X-Bacon',               'Combos',       'X-Bacon + batata frita + refrigerante 300ml', 34.90, 'Lanche', 1),
    ('Combo X-Salada',              'Combos',       'X-Salada + batata frita + refrigerante 300ml', 31.90, 'Lanche', 1),
    -- Refrigerantes
    ('Coca-Cola Lata 350ml',        'Refrigerantes','Lata gelada, 350ml', 7.00, 'Bebida', 1),
    ('Guaraná Antarctica Lata 350ml','Refrigerantes','Lata gelada, 350ml', 7.00, 'Bebida', 1),
    ('Refrigerante 300ml (Copo)',   'Refrigerantes','Copo de refrigerante gelado, 300ml', 6.50, 'Bebida', 1),
    -- Sucos
    ('Suco de Laranja 300ml',       'Sucos',        'Suco natural de laranja, 300ml', 9.00, 'Bebida', 1),
    ('Suco de Maracujá 300ml',      'Sucos',        'Suco natural de maracujá, 300ml', 9.50, 'Bebida', 1),
    -- Águas
    ('Água Mineral 500ml Sem Gás',  'Águas',        'Garrafa de água mineral sem gás, 500ml', 5.00, 'Bebida', 1),
    ('Água Mineral 500ml Com Gás',  'Águas',        'Garrafa de água mineral com gás, 500ml', 5.50, 'Bebida', 1),
    -- Milk-shakes
    ('Milk-shake de Chocolate 400ml','Milk-shakes', 'Sorvete de creme, leite e calda de chocolate', 15.90, 'Bebida', 1),
    ('Milk-shake de Morango 400ml', 'Milk-shakes',  'Sorvete de creme, leite e morango', 15.90, 'Bebida', 1);

-- =====================================================================
-- INGREDIENTES_RECEITA (receita de cada item, ligando aos insumos)
-- =====================================================================

-- X-Salada
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Pão brioche' nome, 1 quantidade, 'un' unidade
 UNION ALL SELECT 'Hambúrguer 150g', 1, 'un'
 UNION ALL SELECT 'Queijo prato (fatia)', 1, 'un'
 UNION ALL SELECT 'Alface', 0.05, 'kg'
 UNION ALL SELECT 'Tomate', 0.08, 'kg') v
WHERE ic.nome = 'X-Salada' AND i.nome = v.nome;

-- X-Bacon
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Pão brioche' nome, 1 quantidade, 'un' unidade
 UNION ALL SELECT 'Hambúrguer 150g', 1, 'un'
 UNION ALL SELECT 'Queijo prato (fatia)', 2, 'un'
 UNION ALL SELECT 'Bacon (fatia)', 3, 'un') v
WHERE ic.nome = 'X-Bacon' AND i.nome = v.nome;

-- X-Tudo
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Pão brioche' nome, 1 quantidade, 'un' unidade
 UNION ALL SELECT 'Hambúrguer 150g', 2, 'un'
 UNION ALL SELECT 'Queijo prato (fatia)', 2, 'un'
 UNION ALL SELECT 'Bacon (fatia)', 4, 'un'
 UNION ALL SELECT 'Alface', 0.05, 'kg'
 UNION ALL SELECT 'Tomate', 0.08, 'kg'
 UNION ALL SELECT 'Molho especial', 0.03, 'L') v
WHERE ic.nome = 'X-Tudo' AND i.nome = v.nome;

-- Cheddar Bacon Burger
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Pão brioche' nome, 1 quantidade, 'un' unidade
 UNION ALL SELECT 'Hambúrguer 150g', 1, 'un'
 UNION ALL SELECT 'Cheddar (fatia)', 2, 'un'
 UNION ALL SELECT 'Bacon (fatia)', 3, 'un'
 UNION ALL SELECT 'Cebola caramelizada', 0.03, 'kg') v
WHERE ic.nome = 'Cheddar Bacon Burger' AND i.nome = v.nome;

-- Chicken Burger
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Pão brioche' nome, 1 quantidade, 'un' unidade
 UNION ALL SELECT 'Peito de frango grelhado (filé)', 1, 'un'
 UNION ALL SELECT 'Alface', 0.03, 'kg'
 UNION ALL SELECT 'Tomate', 0.05, 'kg'
 UNION ALL SELECT 'Maionese verde', 0.02, 'L') v
WHERE ic.nome = 'Chicken Burger' AND i.nome = v.nome;

-- Misto Quente
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Pão de forma (fatia)' nome, 2 quantidade, 'un' unidade
 UNION ALL SELECT 'Presunto (fatia)', 2, 'un'
 UNION ALL SELECT 'Queijo prato (fatia)', 2, 'un') v
WHERE ic.nome = 'Misto Quente' AND i.nome = v.nome;

-- Sanduíche Natural de Frango
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Pão integral' nome, 1 quantidade, 'un' unidade
 UNION ALL SELECT 'Frango desfiado', 0.08, 'kg'
 UNION ALL SELECT 'Alface', 0.03, 'kg'
 UNION ALL SELECT 'Tomate', 0.05, 'kg'
 UNION ALL SELECT 'Requeijão cremoso', 0.03, 'kg') v
WHERE ic.nome = 'Sanduíche Natural de Frango' AND i.nome = v.nome;

-- Batata Frita
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, 0.30, 'kg' FROM itens_cardapio ic, insumos i
WHERE ic.nome = 'Batata Frita' AND i.nome = 'Batata frita congelada';

-- Onion Rings
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, 0.25, 'kg' FROM itens_cardapio ic, insumos i
WHERE ic.nome = 'Onion Rings' AND i.nome = 'Onion rings congelados';

-- Batata com Cheddar e Bacon
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Batata frita congelada' nome, 0.30 quantidade, 'kg' unidade
 UNION ALL SELECT 'Cheddar (fatia)', 3, 'un'
 UNION ALL SELECT 'Bacon (fatia)', 3, 'un') v
WHERE ic.nome = 'Batata com Cheddar e Bacon' AND i.nome = v.nome;

-- Combo X-Bacon
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Pão brioche' nome, 1 quantidade, 'un' unidade
 UNION ALL SELECT 'Hambúrguer 150g', 1, 'un'
 UNION ALL SELECT 'Queijo prato (fatia)', 2, 'un'
 UNION ALL SELECT 'Bacon (fatia)', 3, 'un'
 UNION ALL SELECT 'Batata frita congelada', 0.20, 'kg'
 UNION ALL SELECT 'Refrigerante (ml)', 0.3, 'L'
 UNION ALL SELECT 'Copo descartável 300ml', 1, 'un') v
WHERE ic.nome = 'Combo X-Bacon' AND i.nome = v.nome;

-- Combo X-Salada
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Pão brioche' nome, 1 quantidade, 'un' unidade
 UNION ALL SELECT 'Hambúrguer 150g', 1, 'un'
 UNION ALL SELECT 'Queijo prato (fatia)', 1, 'un'
 UNION ALL SELECT 'Alface', 0.05, 'kg'
 UNION ALL SELECT 'Tomate', 0.08, 'kg'
 UNION ALL SELECT 'Batata frita congelada', 0.20, 'kg'
 UNION ALL SELECT 'Refrigerante (ml)', 0.3, 'L'
 UNION ALL SELECT 'Copo descartável 300ml', 1, 'un') v
WHERE ic.nome = 'Combo X-Salada' AND i.nome = v.nome;

-- Coca-Cola Lata
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, 1, 'un' FROM itens_cardapio ic, insumos i
WHERE ic.nome = 'Coca-Cola Lata 350ml' AND i.nome = 'Coca-Cola lata 350ml';

-- Guaraná Antarctica Lata
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, 1, 'un' FROM itens_cardapio ic, insumos i
WHERE ic.nome = 'Guaraná Antarctica Lata 350ml' AND i.nome = 'Guaraná Antarctica lata 350ml';

-- Refrigerante 300ml (Copo)
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Refrigerante (ml)' nome, 0.3 quantidade, 'L' unidade
 UNION ALL SELECT 'Copo descartável 300ml', 1, 'un') v
WHERE ic.nome = 'Refrigerante 300ml (Copo)' AND i.nome = v.nome;

-- Suco de Laranja
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Suco natural (ml)' nome, 0.3 quantidade, 'L' unidade
 UNION ALL SELECT 'Copo descartável 300ml', 1, 'un') v
WHERE ic.nome = 'Suco de Laranja 300ml' AND i.nome = v.nome;

-- Suco de Maracujá
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Suco de maracujá (ml)' nome, 0.3 quantidade, 'L' unidade
 UNION ALL SELECT 'Copo descartável 300ml', 1, 'un') v
WHERE ic.nome = 'Suco de Maracujá 300ml' AND i.nome = v.nome;

-- Água Mineral Sem Gás
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, 1, 'un' FROM itens_cardapio ic, insumos i
WHERE ic.nome = 'Água Mineral 500ml Sem Gás' AND i.nome = 'Água mineral';

-- Água Mineral Com Gás
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, 1, 'un' FROM itens_cardapio ic, insumos i
WHERE ic.nome = 'Água Mineral 500ml Com Gás' AND i.nome = 'Água mineral com gás';

-- Milk-shake de Chocolate
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Sorvete de creme' nome, 0.15 quantidade, 'kg' unidade
 UNION ALL SELECT 'Leite integral', 0.20, 'L'
 UNION ALL SELECT 'Chantilly', 0.02, 'L'
 UNION ALL SELECT 'Copo descartável 500ml', 1, 'un') v
WHERE ic.nome = 'Milk-shake de Chocolate 400ml' AND i.nome = v.nome;

-- Milk-shake de Morango
INSERT INTO ingredientes_receita (item_cardapio_id, insumo_id, quantidade, unidade)
SELECT ic.id, i.id, v.quantidade, v.unidade FROM itens_cardapio ic, insumos i,
(SELECT 'Sorvete de creme' nome, 0.15 quantidade, 'kg' unidade
 UNION ALL SELECT 'Leite integral', 0.20, 'L'
 UNION ALL SELECT 'Chantilly', 0.02, 'L'
 UNION ALL SELECT 'Copo descartável 500ml', 1, 'un') v
WHERE ic.nome = 'Milk-shake de Morango 400ml' AND i.nome = v.nome;

-- =====================================================================
-- MESAS (12 mesas; algumas já com status variado para teste)
-- =====================================================================
INSERT INTO mesas (numero, status) VALUES
    (1, 'Livre'), (2, 'Livre'), (3, 'Ocupada'), (4, 'Livre'),
    (5, 'Ocupada'), (6, 'Livre'), (7, 'Fechando'), (8, 'Livre'),
    (9, 'Livre'), (10, 'Livre'), (11, 'Livre'), (12, 'Livre');

-- =====================================================================
-- PEDIDOS + ITENS_PEDIDO (exemplos em estados diferentes)
-- =====================================================================

-- Pedido A: Mesa 1 — já foi fechado (histórico de venda concluída)
INSERT INTO pedidos (mesa_id, desconto, enviado_para_cozinha, status_preparo, forma_pagamento, aberto_em, fechado_em)
VALUES ((SELECT id FROM mesas WHERE numero = 1), 0.00, 1, 'Finalizado', 'Pix', NOW() - INTERVAL 40 MINUTE, NOW() - INTERVAL 5 MINUTE);
SET @pedidoA = LAST_INSERT_ID();

INSERT INTO itens_pedido (pedido_id, item_cardapio_id, preco_unitario, quantidade)
SELECT @pedidoA, ic.id, ic.preco_venda, v.quantidade FROM itens_cardapio ic,
(SELECT 'X-Bacon' nome, 2 quantidade
 UNION ALL SELECT 'Coca-Cola Lata 350ml', 2) v
WHERE ic.nome = v.nome;

-- Pedido B: Mesa 3 — ainda sendo montado, não enviado à cozinha
INSERT INTO pedidos (mesa_id, desconto, enviado_para_cozinha, status_preparo, forma_pagamento, aberto_em, fechado_em)
VALUES ((SELECT id FROM mesas WHERE numero = 3), 0.00, 0, 'AguardandoPreparo', NULL, NOW() - INTERVAL 5 MINUTE, NULL);
SET @pedidoB = LAST_INSERT_ID();

INSERT INTO itens_pedido (pedido_id, item_cardapio_id, preco_unitario, quantidade)
SELECT @pedidoB, ic.id, ic.preco_venda, v.quantidade FROM itens_cardapio ic,
(SELECT 'X-Salada' nome, 1 quantidade
 UNION ALL SELECT 'Suco de Laranja 300ml', 1) v
WHERE ic.nome = v.nome;

-- Pedido C: Mesa 5 — enviado à cozinha, em preparo
INSERT INTO pedidos (mesa_id, desconto, enviado_para_cozinha, status_preparo, forma_pagamento, aberto_em, fechado_em)
VALUES ((SELECT id FROM mesas WHERE numero = 5), 2.00, 1, 'EmPreparo', NULL, NOW() - INTERVAL 15 MINUTE, NULL);
SET @pedidoC = LAST_INSERT_ID();

INSERT INTO itens_pedido (pedido_id, item_cardapio_id, preco_unitario, quantidade)
SELECT @pedidoC, ic.id, ic.preco_venda, v.quantidade FROM itens_cardapio ic,
(SELECT 'Combo X-Bacon' nome, 1 quantidade
 UNION ALL SELECT 'Onion Rings', 1
 UNION ALL SELECT 'Guaraná Antarctica Lata 350ml', 2) v
WHERE ic.nome = v.nome;

-- Pedido D: Mesa 7 — pronto, aguardando fechamento (mesa "Fechando")
INSERT INTO pedidos (mesa_id, desconto, enviado_para_cozinha, status_preparo, forma_pagamento, aberto_em, fechado_em)
VALUES ((SELECT id FROM mesas WHERE numero = 7), 0.00, 1, 'Finalizado', NULL, NOW() - INTERVAL 30 MINUTE, NULL);
SET @pedidoD = LAST_INSERT_ID();

INSERT INTO itens_pedido (pedido_id, item_cardapio_id, preco_unitario, quantidade)
SELECT @pedidoD, ic.id, ic.preco_venda, v.quantidade FROM itens_cardapio ic,
(SELECT 'Chicken Burger' nome, 1 quantidade
 UNION ALL SELECT 'Batata Frita', 1
 UNION ALL SELECT 'Milk-shake de Chocolate 400ml', 1) v
WHERE ic.nome = v.nome;

-- =====================================================================
-- Conferência
-- =====================================================================
SELECT * FROM insumos;
SELECT * FROM itens_cardapio;
SELECT * FROM ingredientes_receita;
SELECT * FROM mesas;
SELECT * FROM pedidos;
SELECT * FROM itens_pedido;