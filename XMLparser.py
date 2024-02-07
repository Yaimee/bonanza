import xml.etree.ElementTree as ET
from user import User

def read_users_from_xml(filename):
    # Parse the XML file
    tree = ET.parse(filename)
    root = tree.getroot()
    
    users = []
    # Iterate over each user element
    for user_elem in root.findall('user'):
        # Extract user details
        user_id = int(user_elem.find('user_id').text)
        name = user_elem.find('name').text
        email = user_elem.find('email').text
        
        # Create a User instance and add it to the list
        users.append(User(user_id, name, email))
    
    return users

# Assuming the file name is "file5.xml" and is in the correct path
users = read_users_from_xml("file5.xml")

for user in users:
    print(user.printUser())
