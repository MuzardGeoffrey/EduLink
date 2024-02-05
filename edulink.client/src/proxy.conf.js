const PROXY_CONFIG = [
  {
    context: [
      "/",
    ],
    target: "https://localhost:7144",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
