Rails.application.routes.draw do
  get 'pages/home'
  get 'pages/wiki'
  root 'pages#home'

  namespace :enemies do
    get 'knife_skeleton'
  end
  # For details on the DSL available within this file, see http://guides.rubyonrails.org/routing.html
end
