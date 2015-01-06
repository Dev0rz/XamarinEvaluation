#/usr/bin/env python3

# we need python3 and cherrypy for this script ;-)

import cherrypy
import csv
import json
import os

csv_file = open(os.path.join(os.environ['HOME'], 'data.csv'))
csv_dict = csv.DictReader(csv_file)

data_dict = {}
for item in csv_dict:
    data_dict[item['ProcessNr']] = item

user_dict = {
    'admin': 'foobar'
}

checkpassword = cherrypy.lib.auth_basic.checkpassword_dict(user_dict)
basic_auth = {'tools.auth_basic.on': True,
              'tools.auth_basic.realm': 'srv',
              'tools.auth_basic.checkpassword': checkpassword,

}

class Data:

    exposed = True

    def GET(self, id=None):
        if id == None:
            return(json.dumps(data_dict))
        elif id in data_dict:
            return(json.dumps(data_dict[id]))
        else:
            return('Unknown id')

if __name__ == '__main__':

    cherrypy.tree.mount(
        Data(), '/api',
        {'/':
            {
                'request.dispatch': cherrypy.dispatch.MethodDispatcher(),
                'tools.auth_basic.on': True,
                'tools.auth_basic.realm': 'srv',
                'tools.auth_basic.checkpassword': checkpassword,
            }
        },
    )

    cherrypy.engine.start()
    cherrypy.engine.block()
