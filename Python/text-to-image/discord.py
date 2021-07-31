import requests
import base64

API_ENDPOINT = 'https://discord.com/api/v6'
CLIENT_ID = '123498760123904033'
CLIENT_SECRET = 'abcd1234abcd-ZXYWabcd123456789ZZ'
REDIRECT_URI = 'http://localhost'

def refresh_token(refresh_token):
  data = {
    'client_id': CLIENT_ID,
    'client_secret': CLIENT_SECRET,
    'grant_type': 'refresh_token',
    'refresh_token': refresh_token,
    'redirect_uri': REDIRECT_URI,
    'scope': 'identify email connections'
  }
  headers = {
    'Content-Type': 'application/x-www-form-urlencoded'
  }
  r = requests.post('%s/oauth2/token' % API_ENDPOINT, data=data, headers=headers)
  r.raise_for_status()
  return r.json()

def get_token():
  data = {
    'grant_type': 'client_credentials',
    'scope': 'identify connections'
  }
  headers = {
    'Content-Type': 'application/x-www-form-urlencoded'
  }
  r = requests.post('%s/oauth2/token' % API_ENDPOINT, data=data, headers=headers, auth=(CLIENT_ID, CLIENT_SECRET))
  r.raise_for_status()
  return r.json()

def get_channels():
  r = requests.get('%s/channels' % API_ENDPOINT, auth=(CLIENT_ID, CLIENT_SECRET))


token = get_token()
channels = get_channels()
print(token)
print()
print(channels)