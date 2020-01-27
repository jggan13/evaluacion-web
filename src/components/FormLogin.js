import React, { useState } from 'react';
import axios from 'axios';
import Alert from './Alert';

function FormLogin({history}){

    const [username, setUserName ] = useState('');
    const [password, setPassword ] = useState('');
    const [response, setResponse ] = useState('success');
    const [error, setError] = useState(false);

    const handleSubmit = async (e) => {
        e.preventDefault();
        let url = `http://localhost:61408/api/values/${username}/${password}`;

        if(username === '' || password === ''){
            setError(true);
            return;
        }
         
        setError(false);

        await axios.get(url)
            .then(response => {
                console.log(response.data);
                if(response.data === 'success'){
                    setResponse(response.data);
                    history.push('/products');
                }
                else
                    setResponse(response.data);
            })
            .catch(error => {
                console.log(error);
        }); 

    }

    const mostrar = response === 'success' ? null :  <Alert message="Nombre de usuario o contraseña incorrecta" />;

    return(
        <div className="login-page">
        <div className="form container">
          <form onSubmit={handleSubmit} className="login-form">
            { error?<Alert message="Todos los campos son obligatorios"/> : mostrar}
            <input className="form-control" name="username" onChange={(e) => setUserName(e.target.value)} type="text" placeholder="username"/>
            <input className="form-control" name="password" onChange={(e) => setPassword(e.target.value)} type="password" placeholder="password"/>
            <button>login</button>
          </form>
        </div>
      </div>
    )
}

export default FormLogin;