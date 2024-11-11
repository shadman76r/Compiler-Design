import * as http from 'http';
const server = http.createServer((req,res)=>{
    if(req.url=='/' || req.url=='/home'){
        res.end('<p>This is the surver</p></p>');
    }
    else{
        res.end('<h4>please enter valid url</h4>');
    }
})
server.listen(46262,()=>{
    console.log('surver is running');
})