package compressionpoc

import (
	"fmt"
	"io/ioutil"
	"net/http"
)

func makeCall(encoding string) {
	req, _ := http.NewRequest("GET", "https://localhost:5001/api/users?howMany=100", nil)
	req.Header.Set("Accept-Encoding", encoding)
	client := http.Client{}
	res, err := client.Do(req)
	if err != nil {
		fmt.Printf("The HTTP request failed with error %s\n", err)
	} else {
		ioutil.ReadAll(res.Body)
	}
}
