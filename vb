<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Chat Online do Gustavo</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
        }

        .container {
            width: 80%;
            margin: 0 auto;
            padding: 20px;
            background: #fff;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
        }

        h1 {
            text-align: center;
        }

        #chatArea {
            margin-top: 20px;
            display: none; /* Inicialmente escondido */
        }

        #messages {
            border: 1px solid #ccc;
            padding: 10px;
            height: 300px;
            overflow-y: scroll;
        }

        #messageInput {
            width: 70%;
            padding: 10px;
        }

        #sendButton {
            padding: 10px 20px;
            margin-left: 10px;
        }

        #loginArea, #registerArea {
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        #loginArea input, #registerArea input {
            margin: 10px;
            padding: 10px;
            width: 200px;
        }

        #loginButton, #registerButton {
            padding: 10px 20px;
            margin: 5px;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Chat Online do Gustavo</h1>
        
        <!-- Área de Registro -->
        <div id="registerArea">
            <h2>Registrar</h2>
            <input type="text" id="newUsername" placeholder="Nome de Usuário">
            <input type="password" id="newPassword" placeholder="Senha">
            <button id="registerButton">Registrar</button>
        </div>

        <!-- Área de Login -->
        <div id="loginArea">
            <h2>Login</h2>
            <input type="text" id="username" placeholder="Nome de Usuário">
            <input type="password" id="password" placeholder="Senha">
            <button id="loginButton">Entrar</button>
        </div>

        <!-- Área de Chat -->
        <div id="chatArea">
            <select id="gameSelect">
                <option value="">Selecione um Jogo</option>
                <option value="1">League of Legends</option>
                <option value="2">Valorant</option>
                <option value="3">Counter-Strike</option>
                <option value="4">Fortnite</option>
                <option value="5">Rocket League</option>
                <option value="6">Conversa</option>
                <option value="7">ARK</option>
            </select>
            <div id="messages"></div>
            <input type="text" id="messageInput" placeholder="Digite uma mensagem...">
            <button id="sendButton">Enviar</button>
        </div>
    </div>

    <script>
        const loginArea = document.getElementById('loginArea');
        const registerArea = document.getElementById('registerArea');
        const chatArea = document.getElementById('chatArea');
        const messagesDiv = document.getElementById('messages');
        const messageInput = document.getElementById('messageInput');
        const sendButton = document.getElementById('sendButton');
        
        // Simulação de usuários (deveria ser em um banco de dados em um app real)
        const users = {};

        // Registro de usuários
        document.getElementById('registerButton').addEventListener('click', () => {
            const newUsername = document.getElementById('newUsername').value;
            const newPassword = document.getElementById('newPassword').value;

            if (newUsername && newPassword) {
                if (users[newUsername]) {
                    alert('Usuário já existe! Tente outro nome.');
                } else {
                    users[newUsername] = newPassword;
                    alert('Registro bem-sucedido! Agora faça login.');
                    document.getElementById('newUsername').value = '';
                    document.getElementById('newPassword').value = '';
                }
            } else {
                alert('Por favor, preencha todos os campos.');
            }
        });

        // Login
        document.getElementById('loginButton').addEventListener('click', () => {
            const username = document.getElementById('username').value;
            const password = document.getElementById('password').value;

            if (users[username] && users[username] === password) {
                alert('Login bem-sucedido!');
                loginArea.style.display = 'none';
                registerArea.style.display = 'none';
                chatArea.style.display = 'block';
            } else {
                alert('Usuário ou senha inválidos!');
            }
        });

        // Enviar mensagem
        sendButton.addEventListener('click', () => {
            const selectedGame = gameSelect.value;
            const message = messageInput.value;

            if (selectedGame && message) {
                const gameNames = {
                    1: "League of Legends",
                    2: "Valorant",
                    3: "Counter-Strike",
                    4: "Fortnite",
                    5: "Rocket League",
                    6: "Conversa",
                    7: "ARK"
                };
                const messageElement = document.createElement('div');
                messageElement.textContent = `[${gameNames[selectedGame]}] ${message}`;
                messagesDiv.appendChild(messageElement);
                messageInput.value = '';
            } else {
                alert("Por favor, selecione um jogo e digite uma mensagem.");
            }
        });
    </script>
</body>
</html>