import axios from 'axios';

async function dummy_service() {
    const url = "http://dummy.restapiexample.com/api/v1/employees";
    try {
        const result = await axios.get(url);
        //console.log(result);
        return result.data;
    }
    catch (error) {
        console.log(error);
    }

}

(async function() {
    json_result = await dummy_service();
    console.log(json_result);
})();

