export default class APIManager {
    static getData = section => {
        return fetch(`http://localhost:5001/api/${section}`).then(e => e.json());
    };

    static addData = (section, body) => {
        return fetch(`http://localhost:5001/api/${section}`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            },
            body: JSON.stringify(body)
        });
    };
    static deleteData = (section, id) => {
        return fetch(`http://localhost:5001/api/${section}/${id}`, {
            method: "DELETE"
        })
    };
    static changeStatus = (body, id) => {
        return fetch(`http://localhost:5001/api/products/${id}`, {
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
        return fetch(`http://localhost:5001/api/products/${id}`, {
            method: "PUT",
            headers: {
                "Content-Type": "application/json; charset=utf-8"
            },
            body: JSON.stringify(body)
        })
    }
}