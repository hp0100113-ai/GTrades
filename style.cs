body {
  margin: 0;
  font-family: Arial, sans-serif;
  background: radial-gradient(#111, #000);
  color: white;
  text-align: center;
}

header {
  padding: 40px;
  background: linear-gradient(90deg, purple, red);
}

.products {
  display: flex;
  justify-content: center;
  gap: 20px;
  padding: 40px;
  flex-wrap: wrap;
}

.card {
  background: #111;
  border-radius: 12px;
  width: 250px;
  padding: 20px;
  box-shadow: 0 0 20px rgba(255,0,0,0.4);
  transition: transform 0.2s;
}

.card:hover {
  transform: scale(1.05);
}

.card span {
  display: block;
  font-size: 22px;
  margin: 10px 0;
}

button {
  background: red;
  border: none;
  padding: 12px 20px;
  color: white;
  font-size: 16px;
  border-radius: 8px;
  cursor: pointer;
}

button:hover {
  background: darkred;
}

footer {
  padding: 20px;
  font-size: 12px;
  opacity: 0.6;
}
