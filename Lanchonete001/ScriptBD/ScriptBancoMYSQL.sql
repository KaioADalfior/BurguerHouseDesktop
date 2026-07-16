DROP DATABASE IF EXISTS BurguerHouse;
CREATE DATABASE BurguerHouse;
USE burguerhouse;

-- =====================================================================
-- 1) CARGOS
-- =====================================================================
CREATE TABLE cargos (
    id          INT AUTO_INCREMENT PRIMARY KEY,
    nome        VARCHAR(50)  NOT NULL UNIQUE,
    descricao   VARCHAR(255)
) ENGINE=InnoDB;

INSERT INTO cargos (nome, descricao) VALUES
    ('Admin',      'Acesso total ao sistema, incluindo configurações e financeiro'),
    ('Dono',       'Acesso total ao sistema, incluindo configurações e financeiro'),
    ('Gerente',    'Gerencia operação, estoque, cardápio e equipe'),
    ('Cozinha',    'Acesso à fila de preparo (Kanban de pedidos)'),
    ('Garçom',     'Abre mesas, lança pedidos e fecha contas'),
    ('Financeiro', 'Acesso a relatórios financeiros e fechamento de caixa');

-- =====================================================================
-- 2) USUARIOS
-- =====================================================================
CREATE TABLE usuarios (
    id          INT AUTO_INCREMENT PRIMARY KEY,
    nome        VARCHAR(100) NOT NULL,
    usuario     VARCHAR(50)  NOT NULL UNIQUE,
    senha       VARCHAR(255) NOT NULL,
    cargo_id    INT          NOT NULL,
    ativo       BOOLEAN      NOT NULL DEFAULT TRUE,
    criado_em   TIMESTAMP    NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_usuario_cargo
        FOREIGN KEY (cargo_id) REFERENCES cargos(id)
        ON DELETE RESTRICT
) ENGINE=InnoDB;

INSERT INTO usuarios (nome, usuario, senha, cargo_id, ativo) VALUES
    ('Kaio Andrião Dalfior', 'user', 'user', 1, TRUE);
    
Select * from usuarios;

-- =====================================================================
-- 3) INSUMOS
-- =====================================================================
CREATE TABLE insumos (
    id                  INT AUTO_INCREMENT PRIMARY KEY,
    nome                VARCHAR(100)  NOT NULL,
    categoria           VARCHAR(60)   NOT NULL,
    quantidade_atual    DECIMAL(10,3) NOT NULL DEFAULT 0,
    unidade             VARCHAR(10)   NOT NULL,
    quantidade_minima   DECIMAL(10,3) NOT NULL DEFAULT 0,
    preco_unitario      DECIMAL(10,2) NOT NULL DEFAULT 0,
    criado_em           TIMESTAMP     NOT NULL DEFAULT CURRENT_TIMESTAMP,
    UNIQUE KEY uk_insumos_nome (nome)
) ENGINE=InnoDB;

-- =====================================================================
-- 4) ITENS_CARDAPIO
-- =====================================================================
CREATE TABLE itens_cardapio (
    id              INT AUTO_INCREMENT PRIMARY KEY,
    nome            VARCHAR(100)  NOT NULL,
    categoria       VARCHAR(60),
    descricao       VARCHAR(255),
    preco_venda     DECIMAL(10,2) NOT NULL DEFAULT 0,
    tipo            ENUM('Lanche','Bebida') NOT NULL,
    ativo           BOOLEAN       NOT NULL DEFAULT TRUE,
    criado_em       TIMESTAMP     NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

-- =====================================================================
-- 5) INGREDIENTES_RECEITA
-- =====================================================================
CREATE TABLE ingredientes_receita (
    id                  INT AUTO_INCREMENT PRIMARY KEY,
    item_cardapio_id    INT           NOT NULL,
    insumo_id           INT           NOT NULL,
    quantidade          DECIMAL(10,3) NOT NULL,
    unidade             VARCHAR(10)   NOT NULL,
    CONSTRAINT fk_ingrediente_item
        FOREIGN KEY (item_cardapio_id) REFERENCES itens_cardapio(id)
        ON DELETE CASCADE,
    CONSTRAINT fk_ingrediente_insumo
        FOREIGN KEY (insumo_id) REFERENCES insumos(id)
        ON DELETE RESTRICT,
    UNIQUE KEY uk_item_insumo (item_cardapio_id, insumo_id)
) ENGINE=InnoDB;

-- =====================================================================
-- 6) MESAS
-- =====================================================================
CREATE TABLE mesas (
    id      INT AUTO_INCREMENT PRIMARY KEY,
    numero  INT NOT NULL UNIQUE,
    status  ENUM('Livre','Ocupada','Fechando') NOT NULL DEFAULT 'Livre'
) ENGINE=InnoDB;

-- =====================================================================
-- 7) PEDIDOS
-- =====================================================================
CREATE TABLE pedidos (
    id                      INT AUTO_INCREMENT PRIMARY KEY,
    mesa_id                 INT           NOT NULL,
    desconto                DECIMAL(10,2) NOT NULL DEFAULT 0,
    enviado_para_cozinha    BOOLEAN       NOT NULL DEFAULT FALSE,
    status_preparo          ENUM('AguardandoPreparo','EmPreparo','Entregue','Finalizado')
                            NOT NULL DEFAULT 'AguardandoPreparo',
    forma_pagamento         ENUM('Dinheiro','CartaoDebito','CartaoCredito','Pix') NULL,
    aberto_em               TIMESTAMP     NOT NULL DEFAULT CURRENT_TIMESTAMP,
    fechado_em              TIMESTAMP     NULL,
    CONSTRAINT fk_pedido_mesa
        FOREIGN KEY (mesa_id) REFERENCES mesas(id)
        ON DELETE RESTRICT
) ENGINE=InnoDB;

-- =====================================================================
-- 8) ITENS_PEDIDO
-- =====================================================================
CREATE TABLE itens_pedido (
    id                  INT AUTO_INCREMENT PRIMARY KEY,
    pedido_id           INT           NOT NULL,
    item_cardapio_id    INT           NOT NULL,
    preco_unitario      DECIMAL(10,2) NOT NULL,
    quantidade          INT           NOT NULL DEFAULT 1,
    CONSTRAINT fk_item_pedido_pedido
        FOREIGN KEY (pedido_id) REFERENCES pedidos(id)
        ON DELETE CASCADE,
    CONSTRAINT fk_item_pedido_item_cardapio
        FOREIGN KEY (item_cardapio_id) REFERENCES itens_cardapio(id)
        ON DELETE RESTRICT
) ENGINE=InnoDB;