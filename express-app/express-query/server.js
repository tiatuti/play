const express = require('express'),
      app = express();
//route serves both the form page and processes form data
app.get('/', (request, response)=>{
  console.log(request.query);
  response.sendFile(__dirname +'/form.html');
});
app.listen(3000,()=>console.log('Express server started at port 3000'));
