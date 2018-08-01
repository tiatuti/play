const express = require('express'),
      app = express();
app.get('/:name/:age', (request, response)=>{
   response.send(request.params);
});
app.listen(3000,()=>console.log('Express server started at port 3000'));
