CREATE TABLE sber_users
(
    id SERIAL NOT NULL,
    first_name character varying(255) NOT NULL,
    second_name character varying(255) NOT NULL,
    middle_name character varying(255),
    passport_series character varying(4) NOT NULL,
    passport_number character varying(6) NOT NULL,

    CONSTRAINT pk_sber_users PRIMARY KEY (id),
    CONSTRAINT check_passport_number_only_numbers CHECK (passport_number ~* '^[0-9]*$') NOT VALID
);

CREATE TABLE bank_accounts
(
    id SERIAL NOT NULL,
    user_id INT NOT NULL,
    account_number bigint NOT NULL,
    currency character varying(5) NOT NULL,

    CONSTRAINT pk_bank_accounts PRIMARY KEY (id),
    CONSTRAINT fk_bank_account_to_sber_users
        FOREIGN KEY (user_id)
            REFERENCES sber_users(id),
    CONSTRAINT unq_bank_accounts_account_number UNIQUE (account_number)
);

CREATE TABLE cards
(
    id SERIAL NOT NULL,
    account_id INT NOT NULL,
    card_number character varying(16),
    validity_period_month character varying(2),
    validity_period_year character varying(2),

    CONSTRAINT pk_cards PRIMARY KEY (id),
    CONSTRAINT fk_cards_to_bank_accounts
        FOREIGN KEY (account_id)
            REFERENCES bank_accounts(id),
    CONSTRAINT check_card_number_only_numbers CHECK (card_number ~* '^[0-9 ]*$') NOT VALID,
	CONSTRAINT check_validity_period_month_only_numbers CHECK (validity_period_month ~* '^[0-9]*$') NOT VALID,
	CONSTRAINT check_validity_period_year_only_numbers CHECK (validity_period_year ~* '^[0-9]*$') NOT VALID,
	CONSTRAINT unq_account_cards_account_id_card_number UNIQUE (account_id, card_number)
);