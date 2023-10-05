helm repo add ingress-nginx https://kubernetes.github.io/ingress-nginx
helm repo update
helm upgrade my-ingress --install ingress-nginx --repo https://kubernetes.github.io/ingress-nginx `
  --namespace ingress --set controller.service.externalTrafficPolicy=Local --create-namespace

kubectl --namespace ingress get services my-ingress-ingress-nginx-controller