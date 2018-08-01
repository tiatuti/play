const express = require('express'),
      router = express.Router();

//making use of normal routes
router.get('/john',(request,response)=>{
  response.send('Home of user');
});

router.get('/mark',(request,response)=>{
  response.send('Home of user');
});

//exporting thee router to other modules
module.exports = router;