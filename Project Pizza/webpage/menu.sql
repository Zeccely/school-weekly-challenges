CREATE TABLE IF NOT EXISTS items (
    item_id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL,
    price REAL NOT NULL
);

CREATE TABLE IF NOT EXISTS cart (
    cart_id INTEGER PRIMARY KEY AUTOINCREMENT,
    session_id TEXT NOT NULL,
    item_id INTEGER NOT NULL,
    FOREIGN KEY (item_id) REFERENCES items(item_id)
);

SELECT item_id, name, price, COUNT(*) 
FROM items 
GROUP BY item_id 
HAVING COUNT(*) > 1;


INSERT INTO items (name, price) VALUES ('Pepperoni Pizza', 10.99);
INSERT INTO items (name, price) VALUES ('Prociutto Pizza', 10.99);
INSERT INTO items (name, price) VALUES ('Funghi Pizza', 10.99);
INSERT INTO items (name, price) VALUES ('Quattro formaggi Pizza', 10.99);
INSERT INTO items (name, price) VALUES ('Margherita Pizza', 10.99);
INSERT INTO items (name, price) VALUES ('Capricciosa Pizza', 10.99);

PRAGMA table_info(cart);

DELETE FROM items
WHERE rowid NOT IN (
  SELECT MIN(rowid)
  FROM items
  GROUP BY name, price
);
