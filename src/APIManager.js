export default class APIManager {
    static getData = section => {
        return fetch(`https://localhost:5001/api/${section}`).then(e => e.json());
    };

    static addData = (section, body) => {
        return fetch(`https://localhost:5001/api/${section}`, {
            method: "POST",
            headers: {
                'Access-Control-Allow-Origin':'*',
                "Authorization": `Bearer ${localStorage.getItem("Hairoic")}`,
                "Content-Type": "application/json; charset=utf-8"
            },
            // mode: 'cors',
            body: JSON.stringify(body)
        });
    };
    static deleteData = (section, id) => {
        return fetch(`https://localhost:5001/api/${section}/${id}`, {
            method: "DELETE"
        })
    };
    static changeStatus = (body, id) => {
        return fetch(`https://localhost:5001/api/products/${id}`, {
            method: "PATCH",
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            },
            body: JSON.stringify({
                orderStatus: body
            })
        }).then(e => e.json())
    };
    static editProduct = (body, id) => {
        return fetch(`https://localhost:5001/api/products/${id}`, {
            method: "PUT",
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            },
            body: JSON.stringify(body)
        })
    }
}